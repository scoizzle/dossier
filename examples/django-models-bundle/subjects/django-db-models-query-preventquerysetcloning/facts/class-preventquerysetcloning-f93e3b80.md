# Fact f93e3b80

Store id: 72291b0f-d216-4f3b-a67d-1ffc23724f52

## Text

```text
class PreventQuerySetCloning
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.2666780+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 342,
  "symbol": "PreventQuerySetCloning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":342,"selector":"L342-L361","symbol":"PreventQuerySetCloning"}`

## Items

```json
[
  {
    "text": "Temporarily prevent the given QuerySet from creating new QuerySet instances on each mutating operation (e.g: filter(), exclude() etc), instead modifying the QuerySet in-place.",
    "locator": {
      "line": 343
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::PreventQuerySetCloning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 342,
    "symbol": "PreventQuerySetCloning"
  },
  "id": "72291b0f-d216-4f3b-a67d-1ffc23724f52",
  "items": [
    {
      "locator": {
        "line": 343
      },
      "text": "Temporarily prevent the given QuerySet from creating new QuerySet instances on each mutating operation (e.g: filter(), exclude() etc), instead modifying the QuerySet in-place."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2666780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 342,
        "selector": "L342-L361",
        "symbol": "PreventQuerySetCloning"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5c8f7061-4cf0-477e-91a2-0126a021879b",
  "subject_name": "django/db/models/query::PreventQuerySetCloning",
  "tags": [
    "entity:class"
  ],
  "text": "class PreventQuerySetCloning"
}
```

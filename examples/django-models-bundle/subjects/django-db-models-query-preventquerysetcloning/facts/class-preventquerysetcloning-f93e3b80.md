# Fact f93e3b80

Store id: 230bda2a-743f-4870-b6cd-fe7a863e99c9

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
- posted_at: `2026-11-09T23:32:04.2865010+00:00`

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
  "id": "230bda2a-743f-4870-b6cd-fe7a863e99c9",
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
    "posted_at": "2026-11-09T23:32:04.2865010+00:00"
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
  "subject_id": "e115e634-7fb6-44a8-a762-6f714e648e3d",
  "subject_name": "django/db/models/query::PreventQuerySetCloning",
  "tags": [
    "entity:class"
  ],
  "text": "class PreventQuerySetCloning"
}
```

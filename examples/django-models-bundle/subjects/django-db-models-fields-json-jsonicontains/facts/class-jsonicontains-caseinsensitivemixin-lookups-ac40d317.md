# Fact ac40d317

Store id: ec3edc3d-4408-4823-a2a9-13bba127f831

## Text

```text
class JSONIContains(CaseInsensitiveMixin, lookups.IContains)
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
- posted_at: `2026-11-09T22:39:43.6825980+00:00`

## Data

```json
{
  "end_line": 354,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 353,
  "symbol": "JSONIContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":353,"selector":"L353-L354","symbol":"JSONIContains"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 354,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 353,
    "symbol": "JSONIContains"
  },
  "id": "ec3edc3d-4408-4823-a2a9-13bba127f831",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6825980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 353,
        "selector": "L353-L354",
        "symbol": "JSONIContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "f93349f3-858b-4584-ac47-b51ed9f92df4",
  "subject_name": "django/db/models/fields/json::JSONIContains",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONIContains(CaseInsensitiveMixin, lookups.IContains)"
}
```

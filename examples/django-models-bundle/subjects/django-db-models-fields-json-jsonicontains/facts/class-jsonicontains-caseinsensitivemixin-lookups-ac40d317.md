# Fact ac40d317

Store id: 4f84a6d4-4028-46ac-84b2-443ccb6eb308

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
- posted_at: `2026-11-09T23:44:50.9996060+00:00`

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
  "id": "4f84a6d4-4028-46ac-84b2-443ccb6eb308",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9996060+00:00"
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
  "subject_id": "fa8a9341-7664-4687-92a7-8bda04471e4d",
  "subject_name": "django/db/models/fields/json::JSONIContains",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONIContains(CaseInsensitiveMixin, lookups.IContains)"
}
```

# Fact ac40d317

Store id: 74c82076-7a2b-48f6-84cd-53d541278a8d

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
- posted_at: `2026-11-09T23:31:57.9319110+00:00`

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
  "id": "74c82076-7a2b-48f6-84cd-53d541278a8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9319110+00:00"
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
  "subject_id": "dbb0f910-44ee-4fe2-a152-cbecabf5a597",
  "subject_name": "django/db/models/fields/json::JSONIContains",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONIContains(CaseInsensitiveMixin, lookups.IContains)"
}
```

# Fact b980d4ff

Store id: 94549a80-21a4-4eae-80f3-efd9f23a605e

## Text

```text
def _check_to_fields_exist(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.5193520+00:00`

## Data

```json
{
  "end_line": 640,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 620,
  "symbol": "ForeignObject._check_to_fields_exist"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":620,"selector":"L620-L640","symbol":"ForeignObject._check_to_fields_exist"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject._check_to_fields_exist](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 640,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 620,
    "symbol": "ForeignObject._check_to_fields_exist"
  },
  "id": "94549a80-21a4-4eae-80f3-efd9f23a605e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5193520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 620,
        "selector": "L620-L640",
        "symbol": "ForeignObject._check_to_fields_exist"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "bf930082-2e82-4c87-9f91-56d1d319390e",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_exist",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_exist(self)"
}
```

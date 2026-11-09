# Fact b980d4ff

Store id: 47db4cb4-a7d9-480c-a6e0-0c7366dec690

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
- posted_at: `2026-11-09T22:39:44.3150380+00:00`

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
  "id": "47db4cb4-a7d9-480c-a6e0-0c7366dec690",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3150380+00:00"
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
  "subject_id": "34d19344-02be-45bd-9e1b-25459c429143",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_exist",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_exist(self)"
}
```

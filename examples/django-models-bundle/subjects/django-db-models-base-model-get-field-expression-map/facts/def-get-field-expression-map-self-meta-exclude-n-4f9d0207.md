# Fact 4f9d0207

Store id: 0dbbea52-af80-4a47-b29d-fe2acf1ae161

## Text

```text
def _get_field_expression_map(self, meta, exclude=None)
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
- posted_at: `2026-11-09T23:44:48.5398230+00:00`

## Data

```json
{
  "end_line": 1441,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1397,
  "symbol": "Model._get_field_expression_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1397,"selector":"L1397-L1441","symbol":"Model._get_field_expression_map"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_field_expression_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1441,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1397,
    "symbol": "Model._get_field_expression_map"
  },
  "id": "0dbbea52-af80-4a47-b29d-fe2acf1ae161",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5398230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1397,
        "selector": "L1397-L1441",
        "symbol": "Model._get_field_expression_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "3711ea1b-f209-4116-a9e3-73f5ef941734",
  "subject_name": "django/db/models/base::Model._get_field_expression_map",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_field_expression_map(self, meta, exclude=None)"
}
```

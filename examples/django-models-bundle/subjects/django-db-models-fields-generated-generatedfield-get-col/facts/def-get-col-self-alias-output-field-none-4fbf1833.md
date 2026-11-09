# Fact 4fbf1833

Store id: fbea5dfc-99b3-4007-8b94-3dd4c8e987d7

## Text

```text
def get_col(self, alias, output_field=None)
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
- posted_at: `2026-11-09T23:44:50.8013060+00:00`

## Data

```json
{
  "end_line": 44,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 41,
  "symbol": "GeneratedField.get_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":41,"selector":"L41-L44","symbol":"GeneratedField.get_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.get_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 44,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 41,
    "symbol": "GeneratedField.get_col"
  },
  "id": "fbea5dfc-99b3-4007-8b94-3dd4c8e987d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8013060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 41,
        "selector": "L41-L44",
        "symbol": "GeneratedField.get_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "959bfd09-4597-4e78-a596-f87e12309e61",
  "subject_name": "django/db/models/fields/generated::GeneratedField.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```

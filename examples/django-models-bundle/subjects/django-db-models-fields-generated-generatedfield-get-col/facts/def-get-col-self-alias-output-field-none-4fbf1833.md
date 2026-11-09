# Fact 4fbf1833

Store id: b8b284ab-85ae-4189-9179-e99a47af4c02

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
- posted_at: `2026-11-09T22:39:43.4293000+00:00`

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
  "id": "b8b284ab-85ae-4189-9179-e99a47af4c02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4293000+00:00"
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
  "subject_id": "a2655ad5-3e96-4fc4-a276-abf0edcf3cda",
  "subject_name": "django/db/models/fields/generated::GeneratedField.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```

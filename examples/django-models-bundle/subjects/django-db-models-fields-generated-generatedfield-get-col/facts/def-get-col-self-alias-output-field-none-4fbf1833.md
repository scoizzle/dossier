# Fact 4fbf1833

Store id: 12941776-899a-4931-9a64-643b0f4c2206

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
- posted_at: `2026-11-09T23:31:57.6214370+00:00`

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
  "id": "12941776-899a-4931-9a64-643b0f4c2206",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6214370+00:00"
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
  "subject_id": "c511d35b-13bd-4247-93e5-d1e86e8671fc",
  "subject_name": "django/db/models/fields/generated::GeneratedField.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```

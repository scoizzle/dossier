# Fact a7595c83

Store id: f261550a-40c8-47ae-a3cf-a53ce4df2a7f

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.8129560+00:00`

## Data

```json
{
  "end_line": 201,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 200,
  "symbol": "GeneratedField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":200,"selector":"L200-L201","symbol":"GeneratedField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 201,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 200,
    "symbol": "GeneratedField.get_internal_type"
  },
  "id": "f261550a-40c8-47ae-a3cf-a53ce4df2a7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8129560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 200,
        "selector": "L200-L201",
        "symbol": "GeneratedField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "4131a9e8-5613-4485-b1b3-ac58ee7dde37",
  "subject_name": "django/db/models/fields/generated::GeneratedField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```

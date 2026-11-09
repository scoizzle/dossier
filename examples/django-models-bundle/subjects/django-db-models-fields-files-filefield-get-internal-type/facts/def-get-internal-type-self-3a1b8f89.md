# Fact 3a1b8f89

Store id: 15502ce0-e24d-4170-a9c3-1bef0987af51

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
- posted_at: `2026-11-09T23:31:57.3994850+00:00`

## Data

```json
{
  "end_line": 318,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 317,
  "symbol": "FileField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":317,"selector":"L317-L318","symbol":"FileField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 318,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 317,
    "symbol": "FileField.get_internal_type"
  },
  "id": "15502ce0-e24d-4170-a9c3-1bef0987af51",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3994850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 317,
        "selector": "L317-L318",
        "symbol": "FileField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "8c2a5cbb-de07-4f2e-bdd5-3c62f9bd565e",
  "subject_name": "django/db/models/fields/files::FileField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```

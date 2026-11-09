# Fact 3a1b8f89

Store id: 0373b5a4-8d9c-4f96-8955-348230837411

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
- posted_at: `2026-11-09T22:39:43.2388090+00:00`

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
  "id": "0373b5a4-8d9c-4f96-8955-348230837411",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2388090+00:00"
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
  "subject_id": "93db885c-b572-47fa-ade1-4529e64cd1d7",
  "subject_name": "django/db/models/fields/files::FileField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```

# Fact b9dcf275

Store id: 2685d732-12e3-4029-a04e-c146273466b0

## Text

```text
def save_form_data(self, instance, data)
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
- posted_at: `2026-11-09T23:31:57.4106850+00:00`

## Data

```json
{
  "end_line": 371,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 363,
  "symbol": "FileField.save_form_data"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":363,"selector":"L363-L371","symbol":"FileField.save_form_data"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.save_form_data](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 371,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 363,
    "symbol": "FileField.save_form_data"
  },
  "id": "2685d732-12e3-4029-a04e-c146273466b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4106850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 363,
        "selector": "L363-L371",
        "symbol": "FileField.save_form_data"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "2408775f-75e3-43e6-92da-e6c9c3963edb",
  "subject_name": "django/db/models/fields/files::FileField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```

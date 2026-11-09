# Fact b9dcf275

Store id: 9af525a2-2e9d-4bc6-ab67-212d67d1315b

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
- posted_at: `2026-11-09T22:39:43.2496970+00:00`

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
  "id": "9af525a2-2e9d-4bc6-ab67-212d67d1315b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2496970+00:00"
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
  "subject_id": "7caf2cfe-19ea-4dea-951c-9df1e53566d4",
  "subject_name": "django/db/models/fields/files::FileField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```

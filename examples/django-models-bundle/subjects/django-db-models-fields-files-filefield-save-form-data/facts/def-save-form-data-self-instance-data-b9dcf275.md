# Fact b9dcf275

Store id: 57755597-07d3-4b8a-a7cd-1dfb7473235a

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
- posted_at: `2026-11-09T23:44:50.6654680+00:00`

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
  "id": "57755597-07d3-4b8a-a7cd-1dfb7473235a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6654680+00:00"
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
  "subject_id": "3dc0cbe5-8dfb-4547-8572-6d92d2221cae",
  "subject_name": "django/db/models/fields/files::FileField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```

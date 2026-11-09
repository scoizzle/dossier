# Fact 09615a62

Store id: 3131fac1-bc0b-4351-a018-27714ba4462e

## Text

```text
def pre_save(self, model_instance, add)
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
- posted_at: `2026-11-09T22:39:43.2432080+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 328,
  "symbol": "FileField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":328,"selector":"L328-L342","symbol":"FileField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 328,
    "symbol": "FileField.pre_save"
  },
  "id": "3131fac1-bc0b-4351-a018-27714ba4462e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2432080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 328,
        "selector": "L328-L342",
        "symbol": "FileField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "1c2c4404-0d67-42f3-8ada-fdb06a3d6f06",
  "subject_name": "django/db/models/fields/files::FileField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

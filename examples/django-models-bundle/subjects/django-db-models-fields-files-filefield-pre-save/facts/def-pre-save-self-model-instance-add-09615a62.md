# Fact 09615a62

Store id: b3dd80e3-9904-4be8-9405-e90659bd0970

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
- posted_at: `2026-11-09T23:31:57.4040690+00:00`

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
  "id": "b3dd80e3-9904-4be8-9405-e90659bd0970",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4040690+00:00"
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
  "subject_id": "1bc58c37-48b2-432e-8e3a-3c0218a5925b",
  "subject_name": "django/db/models/fields/files::FileField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

# Fact 1adb5238

Store id: aebe707a-e001-429f-baac-03a10899f81c

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
- posted_at: `2026-11-09T23:31:56.5314340+00:00`

## Data

```json
{
  "end_line": 1140,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1139,
  "symbol": "Field.save_form_data"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1139,"selector":"L1139-L1140","symbol":"Field.save_form_data"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.save_form_data](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1140,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1139,
    "symbol": "Field.save_form_data"
  },
  "id": "aebe707a-e001-429f-baac-03a10899f81c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5314340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1139,
        "selector": "L1139-L1140",
        "symbol": "Field.save_form_data"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "87f3eaaa-843f-4f72-a9e3-df32d7f030e1",
  "subject_name": "django/db/models/fields/__init__::Field.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```

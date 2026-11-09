# Fact 1adb5238

Store id: d50d6a81-0f08-4bec-a0a5-56c444b33a47

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
- posted_at: `2026-11-09T23:44:50.0477260+00:00`

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
  "id": "d50d6a81-0f08-4bec-a0a5-56c444b33a47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0477260+00:00"
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
  "subject_id": "e16db5fe-1620-4d20-a833-5c601a342331",
  "subject_name": "django/db/models/fields/__init__::Field.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```

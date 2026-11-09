# Fact c38d035b

Store id: 89589cea-aec8-4d96-aed1-b0521cbd57de

## Text

```text
def _load_field(app_label, model_name, field_name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9492610+00:00`

## Data

```json
{
  "end_line": 98,
  "entity_kind": "function",
  "parent": "__init__",
  "start_line": 97,
  "symbol": "_load_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L98","symbol":"_load_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::_load_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 98,
    "entity_kind": "function",
    "parent": "__init__",
    "start_line": 97,
    "symbol": "_load_field"
  },
  "id": "89589cea-aec8-4d96-aed1-b0521cbd57de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9492610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L98",
        "symbol": "_load_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6d314da2-7eae-40bd-bb48-dd85dafbfc04",
  "subject_name": "django/db/models/fields/__init__::_load_field",
  "tags": [
    "entity:function"
  ],
  "text": "def _load_field(app_label, model_name, field_name)"
}
```

# Fact c38d035b

Store id: 7f19d04f-ceed-45a0-93b4-5d9d9d725b75

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
- posted_at: `2026-11-09T22:39:42.2451270+00:00`

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
  "id": "7f19d04f-ceed-45a0-93b4-5d9d9d725b75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2451270+00:00"
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
  "subject_id": "82475cfa-25ad-46e0-a0b9-6060bce1196a",
  "subject_name": "django/db/models/fields/__init__::_load_field",
  "tags": [
    "entity:function"
  ],
  "text": "def _load_field(app_label, model_name, field_name)"
}
```

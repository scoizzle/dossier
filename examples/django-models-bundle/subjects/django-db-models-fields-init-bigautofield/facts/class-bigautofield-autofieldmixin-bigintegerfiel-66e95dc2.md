# Fact 66e95dc2

Store id: e7a2ae15-f1c7-434b-ac8c-0d71983c7ce9

## Text

```text
class BigAutoField(AutoFieldMixin, BigIntegerField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.9252800+00:00`

## Data

```json
{
  "end_line": 2976,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2971,
  "symbol": "BigAutoField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2971,"selector":"L2971-L2976","symbol":"BigAutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigAutoField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2976,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2971,
    "symbol": "BigAutoField"
  },
  "id": "e7a2ae15-f1c7-434b-ac8c-0d71983c7ce9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9252800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2971,
        "selector": "L2971-L2976",
        "symbol": "BigAutoField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "eb79234d-f0f8-4bd6-b563-3779cecfe640",
  "subject_name": "django/db/models/fields/__init__::BigAutoField",
  "tags": [
    "entity:class"
  ],
  "text": "class BigAutoField(AutoFieldMixin, BigIntegerField)"
}
```

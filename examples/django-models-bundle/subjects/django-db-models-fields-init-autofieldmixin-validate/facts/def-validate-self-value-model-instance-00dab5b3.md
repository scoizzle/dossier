# Fact 00dab5b3

Store id: c7e8355d-62a1-4ee5-b513-e5660f5ef80c

## Text

```text
def validate(self, value, model_instance)
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
- posted_at: `2026-11-09T23:31:56.8995920+00:00`

## Data

```json
{
  "end_line": 2906,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2905,
  "symbol": "AutoFieldMixin.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2905,"selector":"L2905-L2906","symbol":"AutoFieldMixin.validate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2906,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2905,
    "symbol": "AutoFieldMixin.validate"
  },
  "id": "c7e8355d-62a1-4ee5-b513-e5660f5ef80c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8995920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2905,
        "selector": "L2905-L2906",
        "symbol": "AutoFieldMixin.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f4c11c45-9081-4cb7-96c8-7c4aa41d3b89",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

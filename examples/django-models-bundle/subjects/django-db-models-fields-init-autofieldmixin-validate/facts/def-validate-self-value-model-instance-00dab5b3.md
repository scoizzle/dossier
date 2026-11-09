# Fact 00dab5b3

Store id: fa98d1a2-4520-4a37-b7ad-9616a1ab26bf

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
- posted_at: `2026-11-09T23:44:50.3196190+00:00`

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
  "id": "fa98d1a2-4520-4a37-b7ad-9616a1ab26bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3196190+00:00"
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
  "subject_id": "df2a18d7-53a7-44c4-b1ef-65a3ae19d985",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

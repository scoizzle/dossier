# Fact 834880a4

Store id: 09cb8801-f569-4f2c-87a5-47f622545aeb

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
- posted_at: `2026-11-09T23:31:56.5123880+00:00`

## Data

```json
{
  "end_line": 1028,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1026,
  "symbol": "Field.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1026,"selector":"L1026-L1028","symbol":"Field.pre_save"}`

## Items

```json
[
  {
    "text": "Return field's value just before saving.",
    "locator": {
      "line": 1027
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1028,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1026,
    "symbol": "Field.pre_save"
  },
  "id": "09cb8801-f569-4f2c-87a5-47f622545aeb",
  "items": [
    {
      "locator": {
        "line": 1027
      },
      "text": "Return field's value just before saving."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5123880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1026,
        "selector": "L1026-L1028",
        "symbol": "Field.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ac57428c-d752-4d37-ac70-5b4395c5bcfa",
  "subject_name": "django/db/models/fields/__init__::Field.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

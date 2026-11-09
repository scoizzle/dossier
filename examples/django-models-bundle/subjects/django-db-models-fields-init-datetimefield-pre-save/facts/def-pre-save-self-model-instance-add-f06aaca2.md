# Fact f06aaca2

Store id: 00f90ecb-8e54-48c8-be84-99c947a9894a

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
- posted_at: `2026-11-09T23:31:56.5981030+00:00`

## Data

```json
{
  "end_line": 1696,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1690,
  "symbol": "DateTimeField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1690,"selector":"L1690-L1696","symbol":"DateTimeField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1696,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1690,
    "symbol": "DateTimeField.pre_save"
  },
  "id": "00f90ecb-8e54-48c8-be84-99c947a9894a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5981030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1690,
        "selector": "L1690-L1696",
        "symbol": "DateTimeField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9a8d1059-d44f-46ce-b349-14777c67ef05",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

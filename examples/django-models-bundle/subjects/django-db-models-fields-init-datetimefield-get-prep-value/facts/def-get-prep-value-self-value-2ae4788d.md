# Fact 2ae4788d

Store id: 240c2e58-2595-48eb-aecd-7ee86e0e062d

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:31:56.5994160+00:00`

## Data

```json
{
  "end_line": 1719,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1701,
  "symbol": "DateTimeField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1701,"selector":"L1701-L1719","symbol":"DateTimeField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1719,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1701,
    "symbol": "DateTimeField.get_prep_value"
  },
  "id": "240c2e58-2595-48eb-aecd-7ee86e0e062d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5994160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1701,
        "selector": "L1701-L1719",
        "symbol": "DateTimeField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7cfbf67c-c253-41c0-92f9-fd5b5b50f46a",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```

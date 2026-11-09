# Fact 2ae4788d

Store id: 38690c9c-3afc-4ec2-a3b2-4cb2a66f4d31

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
- posted_at: `2026-11-09T23:44:50.1051000+00:00`

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
  "id": "38690c9c-3afc-4ec2-a3b2-4cb2a66f4d31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1051000+00:00"
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
  "subject_id": "a942f385-d7f6-484f-8b26-008ca84f68f6",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```

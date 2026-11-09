# Fact fde9483c

Store id: 72ed878f-8422-4212-a15f-6a078f42646a

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
- posted_at: `2026-11-09T22:39:42.5131160+00:00`

## Data

```json
{
  "end_line": 2080,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2076,
  "symbol": "FilePathField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2076,"selector":"L2076-L2080","symbol":"FilePathField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2080,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2076,
    "symbol": "FilePathField.get_prep_value"
  },
  "id": "72ed878f-8422-4212-a15f-6a078f42646a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5131160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2076,
        "selector": "L2076-L2080",
        "symbol": "FilePathField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f2449c0e-9f51-4a8f-a7d9-b2703be815b4",
  "subject_name": "django/db/models/fields/__init__::FilePathField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```

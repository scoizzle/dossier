# Fact fde9483c

Store id: 66caaed2-72ce-4854-bd3e-248cdbabaedb

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
- posted_at: `2026-11-09T23:44:50.1488260+00:00`

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
  "id": "66caaed2-72ce-4854-bd3e-248cdbabaedb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1488260+00:00"
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
  "subject_id": "967d924e-d7e9-4aa1-be93-e08a412f2182",
  "subject_name": "django/db/models/fields/__init__::FilePathField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```

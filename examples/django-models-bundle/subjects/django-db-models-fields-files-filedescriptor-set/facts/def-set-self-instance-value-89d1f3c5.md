# Fact 89d1f3c5

Store id: eb18830b-e223-4504-85f5-a58de1a4373b

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T23:44:50.6473620+00:00`

## Data

```json
{
  "end_line": 236,
  "entity_kind": "method",
  "parent": "FileDescriptor",
  "start_line": 235,
  "symbol": "FileDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":235,"selector":"L235-L236","symbol":"FileDescriptor.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 236,
    "entity_kind": "method",
    "parent": "FileDescriptor",
    "start_line": 235,
    "symbol": "FileDescriptor.__set__"
  },
  "id": "eb18830b-e223-4504-85f5-a58de1a4373b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6473620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 235,
        "selector": "L235-L236",
        "symbol": "FileDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "fba8251f-29b4-4b90-bdf9-c092113a4c5b",
  "subject_name": "django/db/models/fields/files::FileDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```

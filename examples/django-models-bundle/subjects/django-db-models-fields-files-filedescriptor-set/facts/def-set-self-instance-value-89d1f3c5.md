# Fact 89d1f3c5

Store id: 76bb465f-ff41-4ffb-966d-f7dfe3dd384a

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
- posted_at: `2026-11-09T23:31:57.3854460+00:00`

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
  "id": "76bb465f-ff41-4ffb-966d-f7dfe3dd384a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3854460+00:00"
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
  "subject_id": "62950b91-4543-49b5-8509-71c1f43610cb",
  "subject_name": "django/db/models/fields/files::FileDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```

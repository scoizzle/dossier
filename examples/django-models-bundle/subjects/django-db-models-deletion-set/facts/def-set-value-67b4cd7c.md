# Fact 67b4cd7c

Store id: 911136d3-2464-49f7-aad0-b56aacd78fd7

## Text

```text
def SET(value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.9995710+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 52,
  "symbol": "SET"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"selector":"L52-L66","symbol":"SET"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 52,
    "symbol": "SET"
  },
  "id": "911136d3-2464-49f7-aad0-b56aacd78fd7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9995710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 52,
        "selector": "L52-L66",
        "symbol": "SET"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "27e1f571-8295-4537-90c0-3f20a3e31adb",
  "subject_name": "django/db/models/deletion::SET",
  "tags": [
    "entity:function"
  ],
  "text": "def SET(value)"
}
```

# Fact 2f6d6761

Store id: e8ff8fa1-c4a7-48a1-8786-3f3eb944dc06

## Text

```text
def return_None()
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
- posted_at: `2026-11-09T23:31:56.4101620+00:00`

## Data

```json
{
  "end_line": 124,
  "entity_kind": "function",
  "parent": "__init__",
  "start_line": 123,
  "symbol": "return_None"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"selector":"L123-L124","symbol":"return_None"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::return_None](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 124,
    "entity_kind": "function",
    "parent": "__init__",
    "start_line": 123,
    "symbol": "return_None"
  },
  "id": "e8ff8fa1-c4a7-48a1-8786-3f3eb944dc06",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4101620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 123,
        "selector": "L123-L124",
        "symbol": "return_None"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "20a8667a-0c3e-41af-b36a-1f633bdced87",
  "subject_name": "django/db/models/fields/__init__::return_None",
  "tags": [
    "entity:function"
  ],
  "text": "def return_None()"
}
```

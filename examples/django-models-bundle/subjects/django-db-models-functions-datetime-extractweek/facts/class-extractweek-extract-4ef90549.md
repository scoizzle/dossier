# Fact 4ef90549

Store id: ac949862-08ee-4889-b90a-5a05651c6b5c

## Text

```text
class ExtractWeek(Extract)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.2085800+00:00`

## Data

```json
{
  "end_line": 148,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 142,
  "symbol": "ExtractWeek"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":142,"selector":"L142-L148","symbol":"ExtractWeek"}`

## Items

```json
[
  {
    "text": "Return 1-52 or 53, based on ISO-8601, i.e., Monday is the first of the week.",
    "locator": {
      "line": 143
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractWeek](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 148,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 142,
    "symbol": "ExtractWeek"
  },
  "id": "ac949862-08ee-4889-b90a-5a05651c6b5c",
  "items": [
    {
      "locator": {
        "line": 143
      },
      "text": "Return 1-52 or 53, based on ISO-8601, i.e., Monday is the first of the week."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2085800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 142,
        "selector": "L142-L148",
        "symbol": "ExtractWeek"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "1026ff57-84f2-4720-b9e4-a7a3e2230a18",
  "subject_name": "django/db/models/functions/datetime::ExtractWeek",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractWeek(Extract)"
}
```

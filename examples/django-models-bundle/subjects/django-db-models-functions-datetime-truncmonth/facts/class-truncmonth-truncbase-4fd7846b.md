# Fact 4fd7846b

Store id: 1fbf6270-11c8-4146-b35f-aa25e8560bbc

## Text

```text
class TruncMonth(TruncBase)
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
- posted_at: `2026-11-09T22:39:46.1954410+00:00`

## Data

```json
{
  "end_line": 370,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 369,
  "symbol": "TruncMonth"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":369,"selector":"L369-L370","symbol":"TruncMonth"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncMonth](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 370,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 369,
    "symbol": "TruncMonth"
  },
  "id": "1fbf6270-11c8-4146-b35f-aa25e8560bbc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1954410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 369,
        "selector": "L369-L370",
        "symbol": "TruncMonth"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "c79a2958-92ec-4711-ba4f-f3196bd3d1bc",
  "subject_name": "django/db/models/functions/datetime::TruncMonth",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncMonth(TruncBase)"
}
```

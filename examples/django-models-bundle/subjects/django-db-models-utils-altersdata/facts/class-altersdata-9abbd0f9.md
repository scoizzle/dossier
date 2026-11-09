# Fact 9abbd0f9

Store id: 9de9b3dd-9cbd-4d31-8ed5-06781bd83ef0

## Text

```text
class AltersData
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
- posted_at: `2026-11-09T22:39:52.1501160+00:00`

## Data

```json
{
  "end_line": 69,
  "entity_kind": "class",
  "parent": "utils",
  "start_line": 55,
  "symbol": "AltersData"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":55,"selector":"L55-L69","symbol":"AltersData"}`

## Items

```json
[
  {
    "text": "Make subclasses preserve the alters_data attribute on overridden methods.",
    "locator": {
      "line": 56
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/utils::AltersData](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 69,
    "entity_kind": "class",
    "parent": "utils",
    "start_line": 55,
    "symbol": "AltersData"
  },
  "id": "9de9b3dd-9cbd-4d31-8ed5-06781bd83ef0",
  "items": [
    {
      "locator": {
        "line": 56
      },
      "text": "Make subclasses preserve the alters_data attribute on overridden methods."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:52.1501160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 55,
        "selector": "L55-L69",
        "symbol": "AltersData"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "31cd343f-2aa2-469a-8506-973b67bad9b1",
  "subject_name": "django/db/models/utils::AltersData",
  "tags": [
    "entity:class"
  ],
  "text": "class AltersData"
}
```

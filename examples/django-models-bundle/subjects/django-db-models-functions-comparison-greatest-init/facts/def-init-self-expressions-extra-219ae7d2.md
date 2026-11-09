# Fact 219ae7d2

Store id: 897d0b83-790e-40d6-81ae-52d339bf3126

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T23:44:53.1712080+00:00`

## Data

```json
{
  "end_line": 137,
  "entity_kind": "method",
  "parent": "Greatest",
  "start_line": 134,
  "symbol": "Greatest.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":134,"selector":"L134-L137","symbol":"Greatest.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Greatest.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 137,
    "entity_kind": "method",
    "parent": "Greatest",
    "start_line": 134,
    "symbol": "Greatest.__init__"
  },
  "id": "897d0b83-790e-40d6-81ae-52d339bf3126",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1712080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 134,
        "selector": "L134-L137",
        "symbol": "Greatest.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "ad60aee8-133e-4d4c-b2e2-41756dc7bac5",
  "subject_name": "django/db/models/functions/comparison::Greatest.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```

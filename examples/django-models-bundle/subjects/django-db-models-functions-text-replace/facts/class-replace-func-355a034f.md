# Fact 355a034f

Store id: c05073b1-81b4-4ac2-a884-f0c3d77ba97c

## Text

```text
class Replace(Func)
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
- posted_at: `2026-11-09T23:32:02.2491560+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 253,
  "symbol": "Replace"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":253,"selector":"L253-L257","symbol":"Replace"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Replace](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 253,
    "symbol": "Replace"
  },
  "id": "c05073b1-81b4-4ac2-a884-f0c3d77ba97c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2491560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 253,
        "selector": "L253-L257",
        "symbol": "Replace"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "305f11d6-f633-45df-9337-ec53f1f4521f",
  "subject_name": "django/db/models/functions/text::Replace",
  "tags": [
    "entity:class"
  ],
  "text": "class Replace(Func)"
}
```

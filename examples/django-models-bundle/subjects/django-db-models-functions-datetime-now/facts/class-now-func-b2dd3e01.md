# Fact b2dd3e01

Store id: 45d47923-40d1-42f7-a0c6-739b272e7874

## Text

```text
class Now(Func)
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
- posted_at: `2026-11-09T23:32:01.2271160+00:00`

## Data

```json
{
  "end_line": 241,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 213,
  "symbol": "Now"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":213,"selector":"L213-L241","symbol":"Now"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Now](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 241,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 213,
    "symbol": "Now"
  },
  "id": "45d47923-40d1-42f7-a0c6-739b272e7874",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2271160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 213,
        "selector": "L213-L241",
        "symbol": "Now"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "151d7bcc-3141-4539-87b6-821274cafde6",
  "subject_name": "django/db/models/functions/datetime::Now",
  "tags": [
    "entity:class"
  ],
  "text": "class Now(Func)"
}
```

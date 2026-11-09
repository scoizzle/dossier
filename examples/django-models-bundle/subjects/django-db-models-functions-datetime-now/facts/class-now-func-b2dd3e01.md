# Fact b2dd3e01

Store id: b1e346d8-5854-4641-81a8-0be8f50dd558

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
- posted_at: `2026-11-09T22:39:46.1580710+00:00`

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
  "id": "b1e346d8-5854-4641-81a8-0be8f50dd558",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1580710+00:00"
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
  "subject_id": "79e1cae9-64cd-48c6-b9ab-8872936995c9",
  "subject_name": "django/db/models/functions/datetime::Now",
  "tags": [
    "entity:class"
  ],
  "text": "class Now(Func)"
}
```

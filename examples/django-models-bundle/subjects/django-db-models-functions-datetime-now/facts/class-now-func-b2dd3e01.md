# Fact b2dd3e01

Store id: 12266b8f-cfc3-4fe3-a291-c217c317bf29

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
- posted_at: `2026-11-09T23:44:53.3669080+00:00`

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
  "id": "12266b8f-cfc3-4fe3-a291-c217c317bf29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3669080+00:00"
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
  "subject_id": "2f1c6477-f9a5-4104-83b7-be6df88bc5a3",
  "subject_name": "django/db/models/functions/datetime::Now",
  "tags": [
    "entity:class"
  ],
  "text": "class Now(Func)"
}
```

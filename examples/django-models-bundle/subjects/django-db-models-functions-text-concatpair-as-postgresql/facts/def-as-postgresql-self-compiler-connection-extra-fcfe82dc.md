# Fact fcfe82dc

Store id: e1181fef-fadb-4848-9a14-2bf7abe2ca6b

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:54.0681350+00:00`

## Data

```json
{
  "end_line": 100,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 88,
  "symbol": "ConcatPair.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L100","symbol":"ConcatPair.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 100,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 88,
    "symbol": "ConcatPair.as_postgresql"
  },
  "id": "e1181fef-fadb-4848-9a14-2bf7abe2ca6b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0681350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L100",
        "symbol": "ConcatPair.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "5515d1a5-c1d7-4cc7-8558-5f9a3e5def1a",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```

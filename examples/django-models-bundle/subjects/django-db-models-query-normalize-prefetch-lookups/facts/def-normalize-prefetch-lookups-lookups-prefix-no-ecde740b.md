# Fact ecde740b

Store id: f4cc58d1-d678-494f-b584-f4c7b04a21d1

## Text

```text
def normalize_prefetch_lookups(lookups, prefix=None)
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
- posted_at: `2026-11-09T23:32:04.8174960+00:00`

## Data

```json
{
  "end_line": 2643,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2634,
  "symbol": "normalize_prefetch_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2634,"selector":"L2634-L2643","symbol":"normalize_prefetch_lookups"}`

## Items

```json
[
  {
    "text": "Normalize lookups into Prefetch objects.",
    "locator": {
      "line": 2635
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::normalize_prefetch_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2643,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2634,
    "symbol": "normalize_prefetch_lookups"
  },
  "id": "f4cc58d1-d678-494f-b584-f4c7b04a21d1",
  "items": [
    {
      "locator": {
        "line": 2635
      },
      "text": "Normalize lookups into Prefetch objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8174960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2634,
        "selector": "L2634-L2643",
        "symbol": "normalize_prefetch_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a2bdfef4-4beb-49dd-93e4-97e9093e8100",
  "subject_name": "django/db/models/query::normalize_prefetch_lookups",
  "tags": [
    "entity:function"
  ],
  "text": "def normalize_prefetch_lookups(lookups, prefix=None)"
}
```

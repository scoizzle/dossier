# Fact ecde740b

Store id: 1d565391-66a3-4e91-988d-9d43c496d6ee

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
- posted_at: `2026-11-09T22:39:49.8690530+00:00`

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
  "id": "1d565391-66a3-4e91-988d-9d43c496d6ee",
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
    "posted_at": "2026-11-09T22:39:49.8690530+00:00"
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
  "subject_id": "132b182a-ffb5-4a22-8708-be4222e3eaad",
  "subject_name": "django/db/models/query::normalize_prefetch_lookups",
  "tags": [
    "entity:function"
  ],
  "text": "def normalize_prefetch_lookups(lookups, prefix=None)"
}
```

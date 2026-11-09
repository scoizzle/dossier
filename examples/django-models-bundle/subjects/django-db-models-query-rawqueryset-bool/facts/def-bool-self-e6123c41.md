# Fact e6123c41

Store id: 0cf97cfd-90d0-4c4a-ad1a-e74d7974b976

## Text

```text
def __bool__(self)
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
- posted_at: `2026-11-09T23:44:56.2385030+00:00`

## Data

```json
{
  "end_line": 2497,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2495,
  "symbol": "RawQuerySet.__bool__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2495,"selector":"L2495-L2497","symbol":"RawQuerySet.__bool__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__bool__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2497,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2495,
    "symbol": "RawQuerySet.__bool__"
  },
  "id": "0cf97cfd-90d0-4c4a-ad1a-e74d7974b976",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2385030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2495,
        "selector": "L2495-L2497",
        "symbol": "RawQuerySet.__bool__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ba0b4d12-a9aa-470e-8f5e-dcb43c0b6774",
  "subject_name": "django/db/models/query::RawQuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```

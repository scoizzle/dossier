# Fact b88955ca

Store id: 6b2de5db-dc53-43a5-be45-384459d27df1

## Text

```text
def next_slice(gen)
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
- posted_at: `2026-11-09T22:39:49.1844590+00:00`

## Data

```json
{
  "end_line": 100,
  "entity_kind": "function",
  "parent": "BaseIterable._async_generator",
  "start_line": 99,
  "symbol": "BaseIterable._async_generator.next_slice"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L100","symbol":"BaseIterable._async_generator.next_slice"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable._async_generator.next_slice](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 100,
    "entity_kind": "function",
    "parent": "BaseIterable._async_generator",
    "start_line": 99,
    "symbol": "BaseIterable._async_generator.next_slice"
  },
  "id": "6b2de5db-dc53-43a5-be45-384459d27df1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.1844590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L100",
        "symbol": "BaseIterable._async_generator.next_slice"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "57913618-0dc5-451b-a308-6122d2ebc96f",
  "subject_name": "django/db/models/query::BaseIterable._async_generator.next_slice",
  "tags": [
    "entity:function"
  ],
  "text": "def next_slice(gen)"
}
```

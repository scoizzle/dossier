# Fact b88955ca

Store id: 032e39d9-a1ae-46b7-955d-cbf6a0b992be

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
- posted_at: `2026-11-09T23:44:55.7655260+00:00`

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
  "id": "032e39d9-a1ae-46b7-955d-cbf6a0b992be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7655260+00:00"
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
  "subject_id": "7f6b8022-a5f1-48af-8db2-ec149415da16",
  "subject_name": "django/db/models/query::BaseIterable._async_generator.next_slice",
  "tags": [
    "entity:function"
  ],
  "text": "def next_slice(gen)"
}
```

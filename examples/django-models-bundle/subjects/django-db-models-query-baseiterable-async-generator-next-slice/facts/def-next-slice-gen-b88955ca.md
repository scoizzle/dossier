# Fact b88955ca

Store id: 2b319e27-8d31-413b-89a9-828f3bd0aed2

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
- posted_at: `2026-11-09T23:32:04.2302840+00:00`

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
  "id": "2b319e27-8d31-413b-89a9-828f3bd0aed2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2302840+00:00"
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
  "subject_id": "ba733ca5-d3a7-45d3-b9a5-1c3d327297e3",
  "subject_name": "django/db/models/query::BaseIterable._async_generator.next_slice",
  "tags": [
    "entity:function"
  ],
  "text": "def next_slice(gen)"
}
```

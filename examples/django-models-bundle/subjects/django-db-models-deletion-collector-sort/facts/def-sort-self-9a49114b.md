# Fact 9a49114b

Store id: 5218f9e8-2308-4fd4-b3ed-8ba77ff29f56

## Text

```text
def sort(self)
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
- posted_at: `2026-11-09T22:39:41.0838010+00:00`

## Data

```json
{
  "end_line": 464,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 448,
  "symbol": "Collector.sort"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":448,"selector":"L448-L464","symbol":"Collector.sort"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.sort](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 464,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 448,
    "symbol": "Collector.sort"
  },
  "id": "5218f9e8-2308-4fd4-b3ed-8ba77ff29f56",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0838010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 448,
        "selector": "L448-L464",
        "symbol": "Collector.sort"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "53046191-f7ba-46c0-bb5b-d53deca0315a",
  "subject_name": "django/db/models/deletion::Collector.sort",
  "tags": [
    "entity:method"
  ],
  "text": "def sort(self)"
}
```

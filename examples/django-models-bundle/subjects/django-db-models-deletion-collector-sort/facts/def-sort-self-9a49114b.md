# Fact 9a49114b

Store id: 0ed96d1a-15d8-4e56-b1f7-da2bb7910a7a

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
- posted_at: `2026-11-09T23:44:48.9167200+00:00`

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
  "id": "0ed96d1a-15d8-4e56-b1f7-da2bb7910a7a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9167200+00:00"
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
  "subject_id": "b46a4303-71a4-45a9-b9dd-379c5cd6f17f",
  "subject_name": "django/db/models/deletion::Collector.sort",
  "tags": [
    "entity:method"
  ],
  "text": "def sort(self)"
}
```

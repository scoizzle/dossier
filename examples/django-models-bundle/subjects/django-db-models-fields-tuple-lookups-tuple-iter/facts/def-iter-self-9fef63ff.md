# Fact 9fef63ff

Store id: 2064f651-86d9-4a59-a3ca-24b0880edde3

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:45.5494260+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "method",
  "parent": "Tuple",
  "start_line": 35,
  "symbol": "Tuple.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L36","symbol":"Tuple.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::Tuple.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "method",
    "parent": "Tuple",
    "start_line": 35,
    "symbol": "Tuple.__iter__"
  },
  "id": "2064f651-86d9-4a59-a3ca-24b0880edde3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5494260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L36",
        "symbol": "Tuple.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a19e128c-1743-4883-889d-e0638130c56f",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```

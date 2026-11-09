# Fact 08ac7323

Store id: 0ed02873-a246-4d07-90ee-8267f071b14c

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:47.9774120+00:00`

## Data

```json
{
  "end_line": 59,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 58,
  "symbol": "Lookup.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":58,"selector":"L58-L59","symbol":"Lookup.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 59,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 58,
    "symbol": "Lookup.__repr__"
  },
  "id": "0ed02873-a246-4d07-90ee-8267f071b14c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9774120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 58,
        "selector": "L58-L59",
        "symbol": "Lookup.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e0fdebe3-f22c-4dd5-aa61-95c73005ec1d",
  "subject_name": "django/db/models/lookups::Lookup.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

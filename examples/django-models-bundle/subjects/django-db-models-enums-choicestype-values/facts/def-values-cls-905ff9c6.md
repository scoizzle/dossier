# Fact 905ff9c6

Store id: be89e47f-8089-4c1d-a733-0cecb1996d55

## Text

```text
def values(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.3035350+00:00`

## Data

```json
{
  "end_line": 51,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 49,
  "symbol": "ChoicesType.values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L51","symbol":"ChoicesType.values"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 51,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 49,
    "symbol": "ChoicesType.values"
  },
  "id": "be89e47f-8089-4c1d-a733-0cecb1996d55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3035350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L51",
        "symbol": "ChoicesType.values"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "ca0347a1-12e8-4954-98ba-892b8a54032e",
  "subject_name": "django/db/models/enums::ChoicesType.values",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def values(cls)"
}
```

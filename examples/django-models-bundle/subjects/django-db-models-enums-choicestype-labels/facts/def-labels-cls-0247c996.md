# Fact 0247c996

Store id: be9760ff-ee58-4a91-a944-1fd4b48f73f0

## Text

```text
def labels(cls)
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
- posted_at: `2026-11-09T23:44:49.0439560+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 45,
  "symbol": "ChoicesType.labels"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":45,"selector":"L45-L47","symbol":"ChoicesType.labels"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.labels](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 45,
    "symbol": "ChoicesType.labels"
  },
  "id": "be9760ff-ee58-4a91-a944-1fd4b48f73f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0439560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 45,
        "selector": "L45-L47",
        "symbol": "ChoicesType.labels"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "613270dd-e7ad-410b-9769-2a889d3943f7",
  "subject_name": "django/db/models/enums::ChoicesType.labels",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def labels(cls)"
}
```

# Fact ead599e7

Store id: aca67249-4e1b-4bbc-8657-d8abd5a27520

## Text

```text
class IntegerFieldOverflow
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.9748340+00:00`

## Data

```json
{
  "end_line": 460,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 445,
  "symbol": "IntegerFieldOverflow"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"selector":"L445-L460","symbol":"IntegerFieldOverflow"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldOverflow](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 460,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 445,
    "symbol": "IntegerFieldOverflow"
  },
  "id": "aca67249-4e1b-4bbc-8657-d8abd5a27520",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9748340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 445,
        "selector": "L445-L460",
        "symbol": "IntegerFieldOverflow"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "020a4927-6cb3-4a35-8d0c-dbf131eb1417",
  "subject_name": "django/db/models/lookups::IntegerFieldOverflow",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerFieldOverflow"
}
```

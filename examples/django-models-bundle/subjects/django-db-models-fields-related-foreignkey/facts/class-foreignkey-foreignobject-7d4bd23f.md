# Fact 7d4bd23f

Store id: 383526f1-3e14-4f8d-9ad1-45c26ad041c5

## Text

```text
class ForeignKey(ForeignObject)
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
- posted_at: `2026-11-09T23:31:58.7385000+00:00`

## Data

```json
{
  "end_line": 1348,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 970,
  "symbol": "ForeignKey"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":970,"selector":"L970-L1348","symbol":"ForeignKey"}`

## Items

```json
[
  {
    "text": "Provide a many-to-one relation by adding a column to the local model to hold the remote value.",
    "locator": {
      "line": 971
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1348,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 970,
    "symbol": "ForeignKey"
  },
  "id": "383526f1-3e14-4f8d-9ad1-45c26ad041c5",
  "items": [
    {
      "locator": {
        "line": 971
      },
      "text": "Provide a many-to-one relation by adding a column to the local model to hold the remote value."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7385000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 970,
        "selector": "L970-L1348",
        "symbol": "ForeignKey"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9490d863-d07c-4a45-8d2d-299f799f141f",
  "subject_name": "django/db/models/fields/related::ForeignKey",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignKey(ForeignObject)"
}
```

# Fact 7d4bd23f

Store id: 84368422-0dc5-48e9-baee-5c5c0c92c9f4

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
- posted_at: `2026-11-09T22:39:44.3675510+00:00`

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
  "id": "84368422-0dc5-48e9-baee-5c5c0c92c9f4",
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
    "posted_at": "2026-11-09T22:39:44.3675510+00:00"
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
  "subject_id": "1046cdf0-0d3d-447a-bf51-03a24254f3aa",
  "subject_name": "django/db/models/fields/related::ForeignKey",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignKey(ForeignObject)"
}
```

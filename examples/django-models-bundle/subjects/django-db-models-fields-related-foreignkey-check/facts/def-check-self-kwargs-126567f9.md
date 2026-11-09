# Fact 126567f9

Store id: ea16aec6-c519-4992-bb83-6826d2fc4ef3

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.3740080+00:00`

## Data

```json
{
  "end_line": 1062,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1056,
  "symbol": "ForeignKey.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1056,"selector":"L1056-L1062","symbol":"ForeignKey.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1062,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1056,
    "symbol": "ForeignKey.check"
  },
  "id": "ea16aec6-c519-4992-bb83-6826d2fc4ef3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3740080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1056,
        "selector": "L1056-L1062",
        "symbol": "ForeignKey.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "57f041c4-2bcd-4b9c-824b-503167f4b6b9",
  "subject_name": "django/db/models/fields/related::ForeignKey.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```

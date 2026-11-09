# Fact 3b9a14df

Store id: 6371178c-c772-4f23-914c-02125c0d3623

## Text

```text
contains function cursor_iter
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.7517920+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/compiler::cursor_iter](../../django-db-models-sql-compiler-cursor-iter/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2276,"symbol":"cursor_iter"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "6371178c-c772-4f23-914c-02125c0d3623",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7517920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2276,
        "symbol": "cursor_iter"
      },
      "rel": "contains",
      "target": "f224fb81-4641-4f5d-9270-75cbb02fc636"
    }
  ],
  "status": "live",
  "subject_id": "a1b39a63-5894-4f24-9b98-7363166e586c",
  "subject_name": "django/db/models/sql/compiler",
  "tags": [
    "entity:function"
  ],
  "text": "contains function cursor_iter"
}
```
